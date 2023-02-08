using bank_ADM.Employees;
using bank_ADM.InternalSystems;
using bank_ADM.Utils;

Director roberta = new Director("Roberta", "9876894321");

Console.WriteLine("Bônus de Roberta: " + roberta.GetBonus());

BonusManager manager = new BonusManager();
manager.SignIn(roberta);

Console.WriteLine("Soma dos bônus: " + manager.TotalBonus);
Console.WriteLine("Total de funcionários: " + Employee.TotalEmployees);

roberta.RaiseSalary();
Console.WriteLine("Novo salário de Roberta: " + roberta.Salary);

Designer felipe = new Designer("Felipe", "9876894321");

Console.WriteLine("Bônus de Felipe: " + felipe.GetBonus());

manager.SignIn(felipe);

Console.WriteLine("Soma dos bônus: " + manager.TotalBonus);
Console.WriteLine("Total de funcionários: " + Employee.TotalEmployees);

felipe.RaiseSalary();
Console.WriteLine("Novo salário de Felipe: " + felipe.Salary);

AcessSystem();


void AcessSystem()
{
    InternalSystem system = new InternalSystem();

    Director ingrid = new Director("Ingrid", "9875621894");
    ingrid.Password = "123";

    AccountManager ursula = new AccountManager("Ursula", "9875621894");
    ursula.Password = "123456";

    system.Login(ingrid, "123");
    system.Login(ursula, "123456");
}