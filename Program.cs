class program {
    static void Main(string[] args){
        Console.Write("Pls input Day of Week : ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Pls input Time of Day : ");
        double time = double.Parse(Console.ReadLine());
        
        while(time >= 8.00 && time <= 18.00){
            Console.Write("Pls input Menu : ");
            string menu = Console.ReadLine();

            if (menu == "Breakfast Set" || menu == "Weekend Set" || menu == "Coffee") {
                switch(menu){

                    case "Breakfast Set":
                        if (time <= 11.00){
                            int a = 0 ;
                            while (a < 5){
                                Console.Write("Pls input Menu : ");
                                string coffee = Console.ReadLine();
                                a++;
                                if (a == 5){
                                    Console.WriteLine("Sorry your order is out of stock");
                                    break;
                                } 
                            }
                        } else{
                            Console.WriteLine("Sorry your order is not available");
                        } 
                    break;

                    case "Weekend Set":
                        if (day == 6 || day == 7){
                            int x = 0;
                            while (x < 2){
                                Console.Write("Pls input Menu : ");
                                string coffee = Console.ReadLine();
                                x++;
                                if (x == 2){
                                    Console.WriteLine("Sorry your order is out of stock");
                                    break;
                                } 
                            }
                        }else {
                            Console.WriteLine("Sorry your order is not available");
                        }
                    break;

                    case "Coffee":
                        int y = 0;
                        while (y < 3){
                            Console.Write("Pls input Menu : ");
                            string coffee = Console.ReadLine();
                            y++;
                            if (y == 3){
                                Console.WriteLine("Sorry your order is out of stock");
                                break;
                            } 
                        } 
                    break;
                    
                    default:
                        Console.WriteLine("Please enter a valid menu");
                    break;
                }
            } else if (menu == "End"){
                break;
            } else {
                Console.WriteLine("Please enter a valid menu");
            }
        }
    }
}