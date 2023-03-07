// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;

List<Form> forms = new List<Form>()
{
    new Form { Id= 1, Name = "Name1", Description = "Description1", Status = FormEnum.Accepted },
    new Form { Id = 2, Name = "Name2", Description = "Description2", Status = FormEnum.Declined }
};

for (int i =0; i< forms.Count(); i++)
{
    Console.WriteLine(forms[i].Name);
}