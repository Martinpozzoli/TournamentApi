using Model.Interface;

namespace Model.Services.Match
{
    public class CompleteMatchService
    {
        private readonly IMatchRepository _matchRepository;
        private readonly IClubRepository _clubRepository;
        private readonly IStandingRepository _standingRepository;

        public CompleteMatchService(
            IMatchRepository matchRepository,
            IClubRepository clubRepository,
            IStandingRepository standingRepository
        )
        {
            _matchRepository = matchRepository;
            _clubRepository = clubRepository;
            _standingRepository = standingRepository;
        }

        public async Task ExecuteAsync(int matchId, int score1, int score2)
        {
            var match = await _matchRepository.SetResult(matchId, score1, score2);
            var localTeam = await _clubRepository.GetId(match.LocalTeamId);
            var visitorTeam = await _clubRepository.GetId(match.VisitorTeamId);
            var localStanding = await _standingRepository.GetId(localTeam.Id);
            var visitorStanding = await _standingRepository.GetId(visitorTeam.Id);

            localStanding.GoalsFor += score1;
            localStanding.GoalsAgainst += score2;
            visitorStanding.GoalsFor += score2;
            visitorStanding.GoalsAgainst += score1;

            if (score1 > score2)
            {
                localStanding.Position += 3;
            }
            else if (score1 < score2)
            {
                visitorStanding.Position += 3;
            }
            else
            {
                localStanding.Position += 1;
                visitorStanding.Position += 1;
            }

            _standingRepository.Edit(localStanding);
            _standingRepository.Edit(visitorStanding);
        }
    }
}
