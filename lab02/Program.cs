using System;
namespace lab02;
public class Program {
    static void Main() {
        //task 1
        ExcellentPupil ep = new ExcellentPupil();
        BadPupil bp = new BadPupil();
        GoodPupil gp = new GoodPupil();
        ExcellentPupil ep2 = new ExcellentPupil();
        ClassRoom cr = new ClassRoom(ep, bp, gp, ep2);
        cr.Print();
        Console.WriteLine("--------------------");
        ClassRoom cr2 = new ClassRoom(ep, bp);
        cr2.Print();
        Console.WriteLine("--------------------");
        //task 2
        Plane pl = new Plane(12, 5, 100000, 200, 2020, 10, 300);
        pl.PrintInfo();
        Car car = new Car(10, 9, 25000, 200, 1999, 4);
        car.PrintInfo();
        Ship sh = new Ship(0, 1, 300000, 300, 2012, 60, "Severny");
        sh.PrintInfo();
        //task 3
        Console.WriteLine("--------------------");
        string key_pro = "pro";
        string key_exp = "expert";
        Console.WriteLine("Введите пароль:");
        string? key_p = Console.ReadLine();
        if (key_p == key_pro)
        {
            ProDocumentWorker prodoc = new ProDocumentWorker();
            prodoc.OpenDocument();
            prodoc.EditDocument();
            prodoc.SaveDocument();
        } else if (key_p == key_exp){
            ExpertDocumentWorker expdoc = new ExpertDocumentWorker();
            expdoc.OpenDocument();
            expdoc.EditDocument();
            expdoc.SaveDocument();
        } else {
            DocumentWorker doc = new DocumentWorker();
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
        }
    }
}
