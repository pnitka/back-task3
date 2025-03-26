//Задача 1: телефонная книга
using System.Collections.Generic;

public class Contact
{
    public string name;
    public string phone;
    public string email;

    public void PrintContact()
    {
        Console.WriteLine("Имя: " + name + ", Телефон: " + phone + ", Email: " + email);
    }
}

public class PhoneBook
{
    public List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    public Contact FindContactByName(string name)
    {
        foreach (Contact contact in contacts)
        {
            if (contact.name == name)
            {
                return contact;
            }
        }
        return null;
    }

    public void RemoveContact(string name)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].name == name)
            {
                contacts.RemoveAt(i);
                return;
            }
        }
    }
}

//Задача 2: Системка управления студентами
using System.Collections.Generic;

public class Student
{
    public string name;
    public List<int> grades = new List<int>();

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public double GetAverageGrade()
    {
        if (grades.Count == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        return (double)sum / grades.Count;
    }
}

public class Classroom
{
    public List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public Student GetTopStudent()
    {
        if (students.Count == 0)
        {
            return null;
        }

        Student topStudent = students[0];
        foreach (Student student in students)
        {
            if (student.GetAverageGrade() > topStudent.GetAverageGrade())
            {
                topStudent = student;
            }
        }
        return topStudent;
    }
}


//Задача 3: Магазин продуктов (я чот устала все писать)
using System.Collections.Generic;

public class Product
{
    public string name;
    public double price;
    public int quantity;

    public void Buy(int amount)
    {
        if (quantity >= amount)
        {
            quantity -= amount;
        }
        else
        {
            Console.WriteLine("Недостаточно товара");
        }
    }
}

public class Store
{
    public List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public Product FindProductByName(string name)
    {
        foreach (Product product in products)
        {
            if (product.name == name)
            {
                return product;
            }
        }
        return null;
    }

    public void SellProduct(string name, int amount)
    {
        Product product = FindProductByName(name);
        if (product != null)
        {
            product.Buy(amount);
        }
        else
        {
            Console.WriteLine("Товар не найден");
        }
    }
}

