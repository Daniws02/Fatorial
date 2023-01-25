Menu();

static void Menu()
{
    Console.Clear();

    Console.Write("Numero: ");
    int numero = int.Parse(Console.ReadLine());

    extraLongFactorials(numero);
}

    static void extraLongFactorials(int n)
    {
        string total = "1";
        for (int i = 2; i <= n; i++)
        {
            total = Multiplo(total, i);
        }

        Console.WriteLine(total);
    }
    static string Multiplo(string a, int b)
    {
        string retorno = "";

        int carry = 0;
        
        for (int i = a.Length - 1; i >= 0; i--)
        {
            int temp = (int.Parse(a[i].ToString()) * b);

            temp += carry;

            carry = 0;

            int unitsPlace = temp % 10;
            retorno = unitsPlace + retorno;

            if (temp > 9)
            {
                carry = temp / 10;
            }
        }

        if (carry != 0)
        {
            retorno = carry + retorno;
        }

        return retorno;
    }