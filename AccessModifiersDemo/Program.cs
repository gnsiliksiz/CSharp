using AccessModifiers;


namespace AccessModifiersDemo
{
    class Program
    {
        //başka bir projedeki classlara erişmek için kullanmak istediğiniz projenin 
        //referansına ekleyip using ile dahil etmeniz gerekmektedir.
        static void Main(string[] args)
        {
            Course course = new Course();
        }
    }
}
