using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IHubs
    {
        HubDetails GetHub(string hub_id);

        Paging<Match> GetMatches(string hub_id, string type = "all", int offset = 0, int limit = 20);

        Paging<Member> GetMembers(string hub_id, int offset = 0, int limit = 20);

        Paging<Role> GetRoles(string hub_id, int offset = 0, int limit = 20);

        Rules GetRules(string hub_id);

        HubStatistics GetStatistics(string hub_id, int offset = 0, int limit = 20);
    }
}
