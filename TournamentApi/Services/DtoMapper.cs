using Microsoft.IdentityModel.Tokens;
using Model.Entities;
using TournamentApi.DTO;

namespace TournamentApi.Services
{
    public class DtoMapper
    {
        // Clubs
        public static ClubResponse MapClubToClubResponse(Club club)
        {
            //map club.Tournaments to ClubTournamentStanding
            List<ClubTournamentStanding> clubTournamentStandings =
                new List<ClubTournamentStanding>();
            if (club.Standings.Count > 0)
            {
                clubTournamentStandings = club.Standings
                    .Select(
                        t =>
                            new ClubTournamentStanding
                            {
                                // aun no trae el nombre del torneo por ser navigation de nivel 2...
                                // https://stackoverflow.com/questions/32412263/using-navigation-to-load-entity-2-level-deep
                                TournamentName = t.Tournament?.Name ?? "",
                                Position = t.Position
                            }
                    )
                    .ToList();
            }
            return new ClubResponse
            {
                Name = club.Name,
                ShortName = club.ShortName,
                TournamentStandings = clubTournamentStandings
            };
        }

        // Players

        //public static PlayerResponse MapPlayerToPlayerResponse(Player player)
        //{
        //    string[] positions = { "Goalkeeper", "Defender", "Midfielder", "Forward" };

        //    return new PlayerResponse
        //    {
        //        Name = player.Name,
        //        Surname = player.Surname,
        //        Birthday = player.BirthDay,
        //        Position = positions[player.Position - 1]
        //        // ClubName = player.Club.Name
        //    };
        //}
    }
}
