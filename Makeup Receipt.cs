using System;

class Program
{
    static void Main(String [] args)
{

    Console.WriteLine("WELCOME TO EMMA's Online Store:");

Console.WriteLine("Enter Lipstick Price: ");
double lipstickPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Lipstick");
int lipstickQty = Convert.ToInt16(Console.ReadLine());

double lipstickTot = lipstickPrice*lipstickQty;

Console.WriteLine("Enter Mascara Price: ");
double mascaraPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Mascara");
int mascaraQty = Convert.ToInt16(Console.ReadLine());

double mascaraTot = mascaraPrice*mascaraQty;

Console.WriteLine("Enter Foundation Price:");
double foundationPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Foundation");
int foundationQty = Convert.ToInt16(Console.ReadLine());

double foundationTot = foundationPrice*foundationQty;

Console.WriteLine("Enter Concealer Price:");
double concealerPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Concealer");
int concealerQty = Convert.ToInt16(Console.ReadLine());

double concealerTot = concealerPrice*concealerQty;

Console.WriteLine("Enter EyeShadow Price:");
double eyeshadowPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Eyeshadow");
int eyeshadowQty = Convert.ToInt16(Console.ReadLine());

double eyeshadowTot = eyeshadowPrice*eyeshadowQty;

Console.WriteLine("Enter Eyeliner Price:");
double eyelinerPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Eyeliner");
int eyelinerQty = Convert.ToInt16(Console.ReadLine());

double eyelinerTot = eyelinerPrice*eyelinerQty;

Console.WriteLine("Enter Powder Price:");
double powderPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Powder");
int powderQty = Convert.ToInt16(Console.ReadLine());

double powderTot = powderPrice*powderQty;

Console.WriteLine("Enter Bronzer Price:");
double bronzerPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: Bronzer");
int bronzerQty = Convert.ToInt16(Console.ReadLine());

double bronzerTot = bronzerPrice*bronzerQty;

Console.WriteLine("Enter MakeupBag Price:");
double makeupbagPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: MakeupBag");
int makeupbagQty = Convert.ToInt16(Console.ReadLine());

double makeupbagTot = makeupbagPrice*makeupbagQty;

Console.WriteLine("Enter MakeupBrushes Price:");
double makeupbrushesPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Quantity: MakeupBrushes");
int makeupbrushesQty = Convert.ToInt16(Console.ReadLine());

double makeupbrushesTot = makeupbrushesPrice*makeupbrushesQty;


Console.WriteLine("Lipstick {0}----R{1}",lipstickQty,lipstickPrice);
Console.WriteLine("Mascara {0}----R{1}",mascaraQty,mascaraPrice);
Console.WriteLine("Foundation {0}----R{1}",foundationQty,foundationPrice);
Console.WriteLine("Concealer {0}---R{1}",concealerQty,concealerPrice);
Console.WriteLine("Eyeshadow {0}---R{1}",eyeshadowQty,eyeshadowPrice);
Console.WriteLine("Eyeliner {0}---R{1}",eyelinerQty,eyelinerPrice);
Console.WriteLine("Powder {0}--R{1}",powderQty,powderPrice);
Console.WriteLine("Bronzer {0}---R{1}",bronzerQty,bronzerPrice);
Console.WriteLine("MakeupBag {0}---R{1}",makeupbagQty,makeupbagPrice);
Console.WriteLine("MakeupBrushes {0}----R{1}",makeupbrushesQty,makeupbrushesPrice);


double totalPrice = (lipstickTot)+(mascaraTot)+(foundationTot)+(concealerTot)+(eyeshadowTot)+(eyelinerTot)+(powderTot)+(bronzerTot)+(makeupbagTot)+(makeupbrushesTot);
Console.WriteLine("Total Price: R{0}",totalPrice);

double vat = totalPrice*15/100;
Console.WriteLine("VAT: R{0}",vat);


}//main method

}//class

        


