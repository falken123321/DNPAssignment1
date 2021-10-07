using System;
using FileData;

namespace Models {
public class Adult : Person {
    public Job JobTitle { get; set; }

    public Adult(int id, String FirstName, string LastName, string haircolor,string EyeColor,int Age, float weight,int height, string sex)
    {
        base.Id = id;
        base.Age = Age;
        base.Height = height;
        base.Sex = sex;
        base.Weight = weight;
        base.HairColor = haircolor;
        base.LastName = LastName;
        base.FirstName = FirstName;
        base.EyeColor = EyeColor;
    }
}
}