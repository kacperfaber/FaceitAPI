using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IChampionship
    {
        ///<summary>Retrieve championship details</summary>
        ChampionshipDetails GetChampionship(string id);

        ///<summary>Retrieve all matches of a championship</summary>
        ///<param name="type">Use ChampionshipMatchesType class.</param>
        ChampionshipMatches GetMatches(string championshipid, string type = "all", int offset = 0, int limit = 20);

        ///<summary>Retrieve all subscriptions of a championship</summary>
        ChampionshipSubscription GetSubscription(string championshipid, int offset = 0, int limit = 10);
    }
}
