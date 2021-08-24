using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.setAgencia("1111");
            c1.setNumero(1111111-1);
            c1.setSaldo(100.50f);

            Cliente cl1 = new Cliente();
            cl1.setNome("Nathaly");
            cl1.setSobrenome("Oliveira");
            cl1.setCpf("111.111.111-11");
            cl1.setConta(c1);

            Conta c2 = new Conta();
            c2.setAgencia("2222");
            c2.setNumero(2222222 - 2);
            c2.setSaldo(200.50f);

            Cliente cl2 = new Cliente();
            cl2.setNome("João");
            cl2.setSobrenome("Silva");
            cl2.setCpf("222.222.222-22");
            cl2.setConta(c2);

            Conta c3 = new Conta();
            c3.setAgencia("3333");
            c3.setNumero(3333333 - 3);
            c3.setSaldo(300.50f);

            Cliente cl3 = new Cliente();
            cl3.setNome("Maria");
            cl3.setSobrenome("Santos");
            cl3.setCpf("333.333.333-33");
            cl3.setConta(c3);

            Console.WriteLine("_________ Cliente 01 _________ \nNome : " + cl1.getNome() + "\nSobrenome : " + cl1.getSobrenome() + "\nCPF : " + cl1.getCpf() + "\nConta : \nAgência : " + c1.getAgencia() + "\nNúmero : " + c1.getNumero() + "\nSaldo : " + c1.getSaldo());
            Console.WriteLine("\n_________ Cliente 02 _________ \nNome : " + cl2.getNome() + "\nSobrenome : " + cl2.getSobrenome() + "\nCPF : " + cl2.getCpf() + "\nConta : \nAgência : " + c2.getAgencia() + "\nNúmero : " + c2.getNumero() + "\nSaldo : " + c2.getSaldo());
            Console.WriteLine("\n_________ Cliente 03 _________ \nNome : " + cl3.getNome() + "\nSobrenome : " + cl3.getSobrenome() + "\nCPF : " + cl3.getCpf() + "\nConta : \nAgência : " + c3.getAgencia() + "\nNúmero : " + c3.getNumero() + "\nSaldo : " + c3.getSaldo());

        }
    }
}
