using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace seesharpbot.Dialogs
{
    [Serializable]
    public class PluralizationDialog : IDialog<object>
    {
        public async System.Threading.Tasks.Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> argument)
        {
            var message = (await argument).Text;
            var depluralizer = PluralizationService.CreateService(new CultureInfo("en-US"));
            var singular = message;
            if (depluralizer.IsPlural(message))
            {
                //convert message to singular form
                singular = depluralizer.Singularize(message);
            }

            await context.PostAsync($"You said {message}, the singular form is {singular}");
            context.Wait(MessageReceivedAsync);

        }
    }
}