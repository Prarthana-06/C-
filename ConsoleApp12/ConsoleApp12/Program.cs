using System;
 
    interface Ipayment
{
    void Makepayment(double amount);
}
class creditcardpaymemt:Ipayment
{
    public void Makepayment(double amount)
    {
        Console.WriteLine($"payment of {amount:c} made using creditcard ");
    }
}
class paypalpayment : Ipayment
{
    public void Makepayment(double amount)
    {
        Console.WriteLine($"payment of {amount:c} made using paypal ");
    }
}
class upipayment : Ipayment
{
    public void Makepayment(double amount)
    {
        Console.WriteLine($"payment of {amount:c} made using upi ");
    }
}
class prog
{
    static void Main()
    {
        Ipayment c = new creditcardpaymemt();
        Ipayment p = new paypalpayment();
        Ipayment u = new upipayment();


        c.Makepayment(1500.00);
        p.Makepayment(1300.00);
        u.Makepayment(500.00);
    }
}