using System;


namespace Models {
    public class Adult : Person {
        public Job jobTitle { get; set; }
    }
}

/*
 public Adult(int id, String firstName, string lastName, string hairColor,string eyeColor,int age, float weight,int height, string sex,string jobTitle,int salary)
    {
        base.Id = id;
        base.Age = age;
        base.Height = height;
        base.Sex = sex;
        base.Weight = weight;
        base.HairColor = hairColor;
        base.LastName = lastName;
        base.FirstName = firstName;
        base.EyeColor = eyeColor;
        Job.JobTitle = jobTitle;
        Job.Salary = salary;

    }
 
 
 */