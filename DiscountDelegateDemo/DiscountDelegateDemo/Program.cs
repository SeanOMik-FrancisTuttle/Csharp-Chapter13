using System;

namespace DiscountDelegateDemo {
    delegate void DiscountDelegate(ref double sale_amount);
    class Program {
        public static void StandardDiscount(ref double sale_amount) {
            const double DISCOUNT_RATE = 0.05;
            const double CUTOFF = 1000.00;
            double discount;
            if (sale_amount >= CUTOFF) {
                discount = sale_amount * DISCOUNT_RATE;
            }
            else {
                discount = 0;
            }
            sale_amount -= discount;
        }
        public static void PreferredDiscount(ref double sale_amount) {
            const double SPECIAL_DISCOUNT = 0.10;
            double discount = sale_amount * SPECIAL_DISCOUNT;
            sale_amount -= discount;
        }
        static void Main(string[] args) {
            DiscountDelegate first_del, second_del;
            first_del = new DiscountDelegate(StandardDiscount);
            second_del = new DiscountDelegate(PreferredDiscount);

            Console.Write("Enter amount of sale ");
            double sale_amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter S for standard discount, or P for preferred discount ");
            char code = Convert.ToChar(Console.ReadLine());
            if (code == 'S') {
                first_del(ref sale_amount);
            } else {
                second_del(ref sale_amount);
            }
            Console.WriteLine("New sale amount is {0}", sale_amount.ToString("C2"));
        }
    }
}
