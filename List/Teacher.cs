public class Teacher: Person {
    public string jobtitle;

    public Teacher(string name, string surname,string age,string allergy,string religion,string jobtitle)
    : base(name,surname,age,allergy,religion) {
        this.jobtitle = jobtitle;
    }
}