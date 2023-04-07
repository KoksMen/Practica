using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeNumberThree pr3 = new PracticeNumberThree();
            int variant = 21;
            pr3.doAction(variant);
            pr3.doAction();
        }

    }

    public class PracticeNumberThree
    {
        public void doAction(int variant)
        {
            for (int i = 1; i <= 10; i++)
            {
                int x = i * variant;
                Console.WriteLine($"Result {i}*{variant} = {x}");
            }
            Console.WriteLine();
        }
        public void doAction() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tПушкин А. С. - Художнику\n");
            sb.AppendLine("Грустен и весел вхожу, ваятель в твою мастерскую:");
            sb.AppendLine("Гипсу ты мысли даешь, мрамор послушен тебе:");
            sb.AppendLine("Сколько богов, и богинь, и героев!.. Вот Зевс громовержец,");
            sb.AppendLine("Вот исподлобья глядит, дуя в цевницу, сатир.");
            sb.AppendLine("Здесь зачинатель Барклай, а здесь совершитель Кутузов.");
            sb.AppendLine("Тут Аполлон — идеал, там Ниобея — печаль…");
            sb.AppendLine("Весело мне. Но меж тем в толпе молчаливых кумиров —");
            sb.AppendLine("Грустен гуляю: со мной доброго Дельвига нет;");
            sb.AppendLine("В темной могиле почил художников друг и советник.");
            sb.AppendLine("Как бы он обнял тебя! Как бы гордился тобой!");
      
            Console.WriteLine(sb.ToString());
        }
    }
}
