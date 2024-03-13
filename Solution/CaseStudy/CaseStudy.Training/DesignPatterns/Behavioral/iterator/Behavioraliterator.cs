namespace CaseStudy.Training.DesignPatterns.Behavioral.iterator
{
    internal class Behavioraliterator
    {
        public static void iterator() 
        {
            BehavioraliteratorEmployeeListAggregate employeeListAggregate = new BehavioraliteratorEmployeeListAggregate();

            BehavioraliteratorEmployee recep = new BehavioraliteratorEmployee(1, "Recep", "Kayserili");
            BehavioraliteratorEmployee saban = new BehavioraliteratorEmployee(2, "Şaban", "Mübarek");
            BehavioraliteratorEmployee ramazan = new BehavioraliteratorEmployee(3, "Ramazan", "Bayram");

            employeeListAggregate.Add(recep);
            employeeListAggregate.Add(saban);
            employeeListAggregate.Add(ramazan);

            var iterator = employeeListAggregate.CreateIterator();

            while (iterator.HasNext())
            {
                BehavioraliteratorEmployee currentEmployee = iterator.GetCurrentItem();
                Console.WriteLine($"{currentEmployee.firstName} {currentEmployee.lastName}");
            }
        }
    }
}
