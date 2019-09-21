using System;
using Smartsheet.Api;
using Smartsheet.Api.Models;
using System.Linq;


namespace SmartsheetTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            String accessToken = "13jxiyjau34mt8snl33sh0zcz9";
            SmartsheetClient smartsheet = new SmartsheetBuilder().SetAccessToken(accessToken).Build();

            UserProfile userProfile = smartsheet.UserResources.GetCurrentUser();
            Console.WriteLine(userProfile.FirstName);

            PaginatedResult<Sheet> sheetsAvailable = smartsheet.SheetResources.ListSheets(null, null, null);
            Console.WriteLine(sheetsAvailable.TotalCount);
            Console.WriteLine(sheetsAvailable.Data[(int)sheetsAvailable.TotalCount - 1].Name);






        }
    }
}
