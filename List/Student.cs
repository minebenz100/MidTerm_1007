public class Student: Person {
    public string Grade;
    public Student(string name, string surname,string age,string allergy,string religion,string grade)
    :base(name,surname,age,allergy,religion) {
        this.Grade = Grade;
    }
}