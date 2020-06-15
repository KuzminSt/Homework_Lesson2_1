using System;

namespace HomeWork_Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Паспортные данные");      //Запрашиваем ФИО
            Console.WriteLine("Введите Ваше имя:");
            string name1 = Console.ReadLine();
            name1 = name1.Trim();
            Console.WriteLine("Введите Ваше отчество:");
            string name2 = Console.ReadLine();
            name2 = name2.Trim();
            Console.WriteLine("Введите Вашу фамилию:");
            string name3 = Console.ReadLine();
            name3 = name3.Trim();
            Console.Clear();

            Console.WriteLine("Место проживания");          //Запрашиваем Место проживания
            Console.WriteLine("Введите город проживания:");
            string city = Console.ReadLine();
            city = city.Trim();
            Console.WriteLine("Введите улицу:");
            string street = Console.ReadLine();
            street = street.Trim();
            Console.WriteLine("Введите номер дома:");
            string house = Console.ReadLine();
            house = house.Trim();
            int houseInt = Convert.ToInt32(house);        //Так как в дальнейшем отсутствуют действия с переменной, требующие перевода строчной переменной в числовую, операция необязательна
            Console.WriteLine("Введите номер квартиры:");
            string apprt = Console.ReadLine();
            apprt = apprt.Trim();
            int apprtInt = Convert.ToInt32(apprt);        //Так как в дальнейшем отсутствуют действия с переменной, требующие перевода строчной переменной в числовую, операция необязательна
            Console.Clear();

            Console.WriteLine("Контактная информация");    //Запрашиваем контактную информацию
            Console.WriteLine("Введите свой номер телефона:");
            string phone = Console.ReadLine();
            phone = phone.Replace("+", " ");                //Приводим международную запись номера телефона к числу
            phone = phone.Trim();
            long phoneLong = Convert.ToInt64(phone);
            Console.Clear();

            Console.WriteLine("Профессиональная деятельность");          //Запрашиваем проф.информацию
            Console.WriteLine("Ваша профессия:");
            String prof = Console.ReadLine();
            prof = prof.Trim();
            Console.WriteLine("Место работы:");
            string pOrg = Console.ReadLine();
            pOrg = pOrg.Trim();
            Console.WriteLine("Занимаемая должность:");
            string pos = Console.ReadLine();
            pos = pos.Trim();
            Console.Clear();

            Console.WriteLine("Физические параметры");               //Запрашиваем физ.параметры
            Console.WriteLine("Введите свой рост (м):");
            string height = Console.ReadLine();
            height = height.Trim().Replace(".", ",");                 //Приводим рост к дробному числу
            double heightDoble = Convert.ToDouble(height);
            Console.WriteLine("Введите свой вес (кг):");
            string weight = Console.ReadLine();
            weight = weight.Trim();
            weight = weight.Replace(".", ",");         //Приводим вес к дробному числу
            double weightDouble = Convert.ToDouble(weight);
            Console.Clear();


            Console.WriteLine($"Фамилия: {name3}\nИмя: {name1} \nОтчество: {name2}");
            Console.WriteLine($"Рост: {heightDoble}\nВес: {weightDouble}");
            Console.WriteLine($"Проживает по адресу: город {city}, улица {street}, дом {houseInt}, квартира {apprtInt}");
            Console.WriteLine($"Профессия: {prof}\nМесто работы: {pOrg}, {pos}");
            Console.WriteLine($"Номер телефона: {phoneLong}");
            Console.ReadLine();


        }
    }
}
