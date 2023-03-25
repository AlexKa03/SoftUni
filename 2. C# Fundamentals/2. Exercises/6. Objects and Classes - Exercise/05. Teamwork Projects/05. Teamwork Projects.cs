using _05._Teamwork_Projects;

class Program
{
    static void Main(string[] args)
    {
        int teamCount = int.Parse(Console.ReadLine());

        List<Team> allTeam = new List<Team>();

        for (int i = 0; i < teamCount; i++)
        {
            string[] inputForTeam = Console.ReadLine()
                .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            string currentCreator = inputForTeam[0];
            string currentTeamNeme = inputForTeam[1];

            bool isTeamNameExist = allTeam
                .Select(x => x.TeamName).Contains(currentTeamNeme);

            bool isCreatorExist = allTeam
                .Any(x => x.CreatorName == currentCreator);

            if (isTeamNameExist == false && isCreatorExist == false)
            {
                Team currentTeam = new Team(currentTeamNeme, currentCreator);

                allTeam.Add(currentTeam);

                Console.WriteLine($"Team {currentTeamNeme} has been created by {currentCreator}!");
            }
            else if (isTeamNameExist)
            {
                Console.WriteLine($"Team {currentTeamNeme} was already created!");
            }
            else if (isCreatorExist)
            {
                Console.WriteLine($"{currentCreator} cannot create another team!");
            }
        }

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end of assignment")
            {
                break;
            }

            string[] inputAssignment = command
                .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            string member = inputAssignment[0];

            string teamName = inputAssignment[1];

            bool isTeamExist = allTeam.Any(x => x.TeamName == teamName);

            bool isCreatorCheating = allTeam.Any(x => x.CreatorName == member);
            bool isAlreadyFen = allTeam.Any(x => x.Members.Contains(member));

            if (isTeamExist && isCreatorCheating == false && isAlreadyFen == false)
            {
                int indexOfTeam = allTeam
                    .FindIndex(x => x.TeamName == teamName);

                allTeam[indexOfTeam].Members.Add(member);
            }
            else if (isTeamExist == false)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (isAlreadyFen || isCreatorCheating)
            {
                Console.WriteLine($"Member {member} cannot join team {teamName}!");
            }
        }

        List<Team> teamWithMember = allTeam
            .Where(x => x.Members.Count > 0)
            .OrderByDescending(x => x.Members.Count)
            .ThenBy(x => x.TeamName)
            .ToList();

        List<Team> notValidTeam = allTeam
            .Where(x => x.Members.Count == 0)
            .OrderBy(x => x.TeamName)
            .ToList();

        foreach (var team in teamWithMember)
        {
            Console.WriteLine(team.TeamName);
            Console.WriteLine("- " + team.CreatorName);
            team.Members.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
        }

        Console.WriteLine("Teams to disband:");

        foreach (var team in notValidTeam)
        {
            Console.WriteLine(team.TeamName);
        }
    }
}