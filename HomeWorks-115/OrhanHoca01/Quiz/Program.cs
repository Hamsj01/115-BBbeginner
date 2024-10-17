namespace Quiz;
/* Quiz
- Kullanıcıya sorular soralım. Sorulara bağlı olarak verdiği cevaplara göre doğru yanlış sayısı gösterelim.
string[] sorular = ["gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?"];
string[] cevaplar = ["mavi", "Ankara"];
string secenekler = ["kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir"]
seçenekler kısmını kullanabilmek için string split fonksiyonunu kullanmayı araştırın. */
class Program
{
    static void Main(string[] args)
    {
        string[] sorular = ["Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?"];
        string[] cevaplar = ["mavi", "Ankara"];
        string[] secenekler = ["A)kırmızı B)Mavi C)Pembe D)Mor", "A)Ankara B)İstanbul C)İzmir D)Mersin"];
        

    for (int i = 0; i < sorular.Length; i++)
        {
            System.Console.WriteLine($"Soru{i+1}\n{sorular[i]}\n{secenekler[i]}");
            
        }









    }
}
