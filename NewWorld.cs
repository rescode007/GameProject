using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    private void PrintNumbers(List<int> numbers)
    {
        string result = "";
        foreach (var number in numbers)
        {
            result += number + " ";
        }
        print(result);
    }

    private List<int> GetDivisibleBy(List<int> numbers, int divisor)
    {
        List<int> divisibleNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (number % divisor == 0)
            {
                divisibleNumbers.Add(number);
            }
        }

        return divisibleNumbers;
    }

    void bolenleriBul(int ilksayi, int ikincisayi)
    {
        List<int> tumSayilar = new List<int>();
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            tumSayilar.Add(i);
        }

        print("Tüm sayılar: " + GetNumberString(tumSayilar));

        print("2'ye bölünenler: " + GetNumberString(GetDivisibleBy(tumSayilar, 2)));

        print("3'e bölünenler: " + GetNumberString(GetDivisibleBy(tumSayilar, 3)));

        print("4'e bölünenler: " + GetNumberString(GetDivisibleBy(tumSayilar, 4)));

        print("5'e bölünenler: " + GetNumberString(GetDivisibleBy(tumSayilar, 5)));
    }

    private string GetNumberString(List<int> numbers)
    {
        string result = "";
        foreach (var number in numbers)
        {
            result += number + "-";
        }
        return result;
    }

    void Start()
    {
        bolenleriBul(6, 77);
    }
}