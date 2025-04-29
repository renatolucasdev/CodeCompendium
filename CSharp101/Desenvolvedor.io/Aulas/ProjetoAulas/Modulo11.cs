namespace Modulo11;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2012, 12, 02, 19, 22, 23);// Criando um objeto DateTime com data e hora
        var date2 = DateTime.Parse("2022/12/22 19:25:23"); // Criando um objeto DateTime a partir de uma string
        var date3 = DateTime.Now; // Criando um objeto DateTime com a data e hora atual
        var date4 = DateTime.Today;// Criando um objeto DateTime com a data atual sem a hora

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));// Formatando a data e hora

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));// Criando um objeto DateTimeOffset com a data e hora atual e o fuso horário de -3 horas. Trabalhando com fusos horários, deslocamento de horas em relação ao UTC
        Console.WriteLine(dateOffset1.LocalDateTime);// Mostrando a data e hora local
        Console.WriteLine(dateOffset1.UtcDateTime);// Mostrando a data e hora UTC

        //DateTimeOffset.UtcNow
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");

        //var diff = date1 - date2; // Subtraindo duas datas, retorna um TimeSpan
        var diff = date1.Subtract(date2);// Subtraindo duas datas, retorna um TimeSpan

        Console.WriteLine((int)diff.TotalDays);// TotalDays retorna o total de dias entre as duas datas. (int) fazendo um cast para inteiro
        Console.WriteLine((int)diff.TotalHours);// TotalHours retorna o total de horas entre as duas datas. (int) fazendo um cast para inteiro

    }

    public void AulaAdicionandoDiasMesAno()
    {
        var date1 = DateTime.Now;
        // Adicionando dias, meses e anos a uma data por meio dos métodos de extensão da classe DateTime
        Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddYears(2).ToString("dd-MM-yyyy HH:mm:ss"));

    }


    public void AulaAdicionandoHoraMinutoSegundos()
    {
        var date1 = DateTime.Now;
        // Adicionando horas, minutos e segundos a uma data por meio dos métodos de extensão da classe DateTime
        Console.WriteLine(date1.ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));

    }

    public void AulaDiaDaSemana()
    {
        var date1 = DateTime.Now;
        // Recuperando o dia da semana de uma data por meio da propriedade DayOfWeek da classe DateTime
        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        // DateOnly é uma estrutura que representa uma data sem hora, minuto e segundo
        //var somenteData = new DateOnly(2025,04,07); // Criando um objeto DateOnly com a data atual
        var somenteData =  DateOnly.Parse("2025-04-07"); // Criando um objeto DateOnly a partir de uma string

        Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
    }
    
    public void AulaTimeOnly()
    {
        // TimeOnly é uma estrutura que representa uma hora, minuto e segundo sem data
        //var outraVariavel = new TimeOnly(12,23,25,0); // Criando um objeto TimeOnly com a hora atual pelo construtor da classe
        var somenteHora =  TimeOnly.Parse("23:01:23");// Criando um objeto TimeOnly a partir de uma string

        Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
    }

}