namespace 구조체
{
    internal class Program
    {
        struct Skill // 열거형은 enum 구조체는 struct (public : 공공의 , 공개적 / 접근 제한자)
        {
           public string skillName;
           public float coolTime;
           public int cost;
           public float range;
        }

        static void Main(string[] args)
        {
            Skill[] skills = new Skill[4];  // Q skill, W skill, R skill, E skill



            Skill fire;
            fire.skillName = "파이어";
            fire.coolTime = 1f;
            fire.cost = 5;
            fire.range = 1f;

            Skill fireWall;
            fireWall.skillName = "파이어 월";
            fireWall.coolTime = 2.5f;
            fireWall.cost = 10;
            fireWall.range = 2.5f;

            Skill fireball;
            fireball.skillName = "파이어 볼";
            fireball.coolTime = 5f;
            fireball.cost = 20;
            fireball.range = 5f;

            Skill meteo;
            meteo.skillName = "메테오";
            meteo.coolTime = 10f;
            meteo.cost = 30;
            meteo.range = 10f;

            skills[0] = fire;
            skills[1] = fireWall;
            skills[2] = fireball;
            skills[3] = meteo;

            while (true)
            {
                Console.Write("사용할 스킬 : ");
                string input = Console.ReadLine();
                int value = int.Parse(input);

                Console.WriteLine("{0} 스킬을 사용합니다.", skills[value].skillName);
                Console.WriteLine("{0} 스킬을 사용합니다.", skills[value].skillName);
                Console.WriteLine("{0} 스킬을 사용합니다.", skills[value].skillName);
                Console.WriteLine("{0} 스킬을 사용합니다.", skills[value].skillName);
            }
            Product product; // 구조체 형식 변수 선언

            product.Id = 1; // 구조체 변수의 각 멤버에 값을 할당
            product.Title = "좋은 책";
            product.Price = 100000M;

            // 구조체 형식 변수 사용
            string message = ($"번호 : {product.Id}\n 상품명 : {product.Title}\n 가격 : {product.Price}");
            Console.WriteLine(message);
        }
    }
}
