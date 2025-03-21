using Microsoft.VisualBasic;

namespace _250317
{
    internal class Program
    {
        struct Item // Item 구조체
        {
            public string name; // 아이템 이름
            public int id; //아이템 고유 ID
        }

        struct Inventory // Inventory 구조체
        {
            public Item[] itemss; // Item 구조체를 보관할 수 있는 배열
        }

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(); // 텅 비어 있는 저장소에 새로운 인벤토리 변수에 들어감
            // 인벤토리 생성 후 내부에서 관리하는 인벤토리의 배열에 대한 크기를 지정할 수 있어야 한다.


            inventory.itemss = new Item[5]; // 초기화 배열 5개 생성

            inventory.itemss[0].name = "대검";
            inventory.itemss[0].id = 434;

            inventory.itemss[1].name = "태도";
            inventory.itemss[1].id = 754;

            inventory.itemss[2].name = "쌍검";
            inventory.itemss[2].id = 802;

            inventory.itemss[3].name = "한손검";
            inventory.itemss[3].id = 230;

            inventory.itemss[4].name = "건랜스";
            inventory.itemss[4].id = 437;

            void call(Item[] items)
            {
                for (int i = 0; i < items.Length; i++) // Length를 써서 모든 아이템 배열 불러오기
                {
                    Console.WriteLine($"{items[i].name} 아이템의 \nID는 {items[i].id} 입니다."); // Item 구조체를 입력 받아 이름과 고유 ID를 콘솔에 출력하는 함수 제작
                }
            }
            call(inventory.itemss); // Inventory 구조체를 입력받아 가지고 있는 아이템을 한줄에 하나씩 전부 출력하는 함수 제작


        }
    }
}
