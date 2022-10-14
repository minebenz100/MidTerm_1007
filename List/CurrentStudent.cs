public class CurrentStudent: Person {
    public string studentID;
    public CurrentStudent(string name, string surname,string age,string allergy,string religion,string studentID)
    : base(name,surname,age,allergy,religion) {
        this.studentID = studentID;
    }
}