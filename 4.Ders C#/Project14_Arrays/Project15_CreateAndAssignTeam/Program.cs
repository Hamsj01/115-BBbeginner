namespace Project15_CreateAndAssignTeam;

class Program
{   static void RandomStudents(string[] students)
{
        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length); //1. öğrenciyi rasgele indexe attı
            string temp = students[i]; // yer değiştirmek için geçici bir yer oluşturduk
            students[i] = students[randomIndex];
            students[randomIndex] = temp;
        }
    }
    static void AssignToTeam(string[] students,string[] teamNazmes,double memberCount)
    {
        int teamCounter = 0;
        string currentTeamName;
        for (int i = 0; i < students.Length; i += 4)
        {
            currentTeamName = teamNazmes[i];

            System.Console.WriteLine($"Takım Adı: {currentTeamName} ");
            for (int j = 0; j < memberCount; j++)
            {
                System.Console.WriteLine($"\t\t-{students[i + j]}");
            }
            System.Console.WriteLine("-----------");
        }
    }

    static string[] GetStudents()
    {
        string[] result=["Hakan Çakdı", "Tunacan Eşki", "Rojin Çetiz", "Elif Öztürk", "Ömer Taştekin", "Enes Kılıçaslan", "Atlas Uyar", "Erdem Yüce Gül", "Enes Can Aydemir", "Burhan Torun", "Miraç Katmer", "Bedirhan Çaly", "Melina Balcı", "Merve Kahraman", "Kerem Can Kırpar", "Gizem Yüksel", "Celal Uğur Koçan", "Tahir Burak Avar","Samet Önür", "Aleyna Çelen", "Elifnur Bilici", "Doğukan Babayiğit","Emre Kılıç" ];
        RandomStudents(result);
        return result;

    }

    static string[] GetTeamNames()
    {
     return["Debuggers", "Codewars", "Algorithmics", "Binarycoders", "NulPointers", "DevDynamics"];
    }


    static void Main(string[] args)
    {
        string[] students=GetStudents();
        string[] teamNazmes=GetTeamNames();
        double memberCount=4;
        int teamCount=(int)Math.Ceiling(students.Length/memberCount);
        string[] team=new string[teamCount];
        //Students dizimizi karıştırıyoruz.
        RandomStudents(students);
        //ref kullanarsak yaparsak ne fark olur?
        AssignToTeam(students, teamNazmes, memberCount);

        
// evde


        // foreach (string s in students)
        // {
        //     System.Console.WriteLine(s);
        // }

    }
}
