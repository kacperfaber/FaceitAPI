using System;
using FaceitAPI.Types;
using FaceitAPI.Models;
using FaceitAPI.Interfaces;
using System.Net.Http;
using System.Linq;
using System.Diagnostics;

namespace FaceitAPI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Authorization auth = new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47");
            Faceit faceit = new Faceit(auth);
            Search search = faceit.GetObject<Search>();
            Players players = faceit.GetObject<Players>();

            // only search have changed IResponse.
            search.Response = new Response();

            while (true)
            {
                System.Console.WriteLine("NICKNAME...");
                string nickname = System.Console.ReadLine();

                var simpleplayer = search.GetPlayers(nickname, "csgo").Items.First();
                var player = players.GetPlayerById(simpleplayer.PlayerId);

                System.Console.WriteLine("country " + player.Country);
                System.Console.WriteLine("friends count " + player.FriendsIds.Length);
                System.Console.WriteLine("steam nickname: " + player.SteamNickname);
                System.Console.WriteLine("faceit url: " + player.FaceitUrl);

                Process.Start(@"C:\Users\kacpe_bcwebie\Google\Chrome\Application\chrome.exe", player.FaceitUrl.Replace("{lang}", "pl"));
            }
        }
    }

    class Response : IResponse
    {
        public void ReadResponse(string response, HttpResponseMessage message)
        {
            System.Console.WriteLine("Response : IResponse :D");
            System.Console.WriteLine("StatusCode is " + (int) message.StatusCode);
        }
    }
}
