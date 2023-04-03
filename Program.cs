namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - İnformasiya almaq üçün");
            Console.WriteLine("1 - Shoot metodu üçün");
            Console.WriteLine("2 - Fire metodu üçün");
            Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
            Console.WriteLine("4 - Reload metodu üçün");
            Console.WriteLine("5 - ChangeFireMode metodu üçün");
            Console.WriteLine("6 - Proqramdan dayandırmaq üçün\n");
            Console.Write("Seciminizi edin: ");
            
            {
                
                int choose = int.Parse(Console.ReadLine());
                while (true)
                {
                    switch (choose)
                    {
                        case 0:
                            Weapon.information();
                            break;
                        case 1:
                            Weapon.Shoot();
                        break;
                        case 2:
                            Weapon.Fire();
                            break;
                        case 3:
                            Weapon.GetRemainBulletCount();
                            break;
                        case 4:
                            Weapon.Reload();
                            break;
                        case 5:
                            Weapon.ChangeFireMode();
                            break;
                        case 6:
                            Console.WriteLine("Goodbye");
                            check = false;
                            break;
                        default:
                            Console.WriteLine("Error")
                            break;
                    }
                }
            }

        }
    }
}