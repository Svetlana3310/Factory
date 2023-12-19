using System;

// Клас для реалізації паттерну Фабрика
public class Factory
{
    // Метод для створення екземпляра конкретного класу (продукту)
    public IProduct CreateProduct(string productType)
    {
        switch (productType.ToLower())
        {
            case "producta":
                return new ProductA();
            case "productb":
                return new ProductB();
            default:
                throw new ArgumentException("Unknown product type");
        }
    }
}

// Інтерфейс продукту
public interface IProduct
{
    void Display();
}

// Реалізація конкретного продукту A
public class ProductA : IProduct
{
    public void Display()
    {
        Console.WriteLine("Product A");
    }
}

// Реалізація конкретного продукту B
public class ProductB : IProduct
{
    public void Display()
    {
        Console.WriteLine("Product B");
    }
}