using System;
using System.Collections.Generic;
using System.Text;

class Collections
{
    public string lastName;
    public string firstName;
    public string univercity;
    public string faculty;
    public int course;
    public string department;
    public int group;
    public string city;
    int age;
    // Создаем конструктор
    public Collections(
        string firstName, 
        string lastName, 
        string univercity, 
        string faculty, 
        string department, 
        int age, 
        int course, 
        int group, 
        string city
        )
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.univercity = univercity;
        this.faculty = faculty;
        this.department = department;
        this.course = course;
        this.age = age;
        this.group = group;
        this.city = city;
    }
}
