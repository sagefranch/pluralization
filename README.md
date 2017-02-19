# pluralization
.NET PluralizationServices demo leveraging Microsoft Bot Framework for delivery


When trying to determing the best way to streamline queries in another project, I found myself looking for a library to perform the plural<->singular conversion for me. Turns out, .NET has one! In the Entity Framework System.Data.Entity.Design dll there is a namespace called PluralizationServices, which performs these operations and accompanying checks for you. 

This demo is a simple bot that takes the user input and spits back the singular form. It shows you how to read user input, use the Pluralizer to check whether the phrase is plural or singular, and either convert or not before sending a message back to the user. 

This implements Microsoft Bot Framework in C#. 

TWO KEY THINGS to get this project to run:
      To run the project, generate your bot app ID, key and password at botframework.com, and input them into the fields in the web.config file.
      In the VS solution explorer, right click on References, go to Add References, and select System.Data.Entity.Design. Add it to your references. 
