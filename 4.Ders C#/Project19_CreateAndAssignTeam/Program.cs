namespace Project15_CreateAndAssignTeam;

class Program
{
    static void Main(string[] args)
    {
        string[] students={"Hakan Çakdı", "Tunacan Eşki", "Rojin Çetiz", "Elif Öztürk", "Ömer Taştekin", "Enes Kılıçaslan", "Atlas Uyar", "Erdem Yüce Gül", "Enes Can Aydemir", "Burhan Torun", "Miraç Katmer", "Bedirhan Çaly", "Melina Balcı", "Merve Kahraman", "Kerem Can Kırpar", "Gizem Yüksel", "Celal Uğur Koçan", "Tahir Burak Avar","Samet Önür", "Aleyna Çelen", "Elifnur Bilici", "Doğukan Babayiğit","Emre Kılıç" };

        string[] teamNazmes={"Debuggers", "Codewars", "Algorithmics", "Binarycoders", "NulPointers", "DevDynamics"};

        double memberCount=4;
        int teamCount=(int)Math.Ceiling(students.Length/memberCount);
        
        string[] team=new string[teamCount];

        //Students dizimizi karıştırıyoruz.
        Random rnd= new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex=rnd.Next(students.Length); //1. öğrenciyi rasgele indexe attı
            string temp=students[i]; // yer değiştirmek için geçici bir yer oluşturduk
            students[i]=students[randomIndex];
            students[randomIndex]= temp;
        }

        int teamCounter=0;
        string currentTeamName;
        for(int i=0; i<students.Length;i+=4)
        {
           currentTeamName=teamNazmes[0] ;
           
           System.Console.WriteLine($"Takım Adı: {currentTeamName} ");
           for (int j = 0; j < memberCount; j++)
           {
            System.Console.WriteLine($"\t\t-{students[i+j]}");
           }
           System.Console.WriteLine("-----------");
        }
// evde







        // foreach (string s in students)
        // {
        //     System.Console.WriteLine(s);
        // }



    }
}
