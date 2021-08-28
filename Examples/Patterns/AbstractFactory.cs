public abstract class SoftwareProfessional {}

public class Designer : SoftwareProfessional {}
public class Developer : SoftwareProfessional {}
public class Manager : SoftwareProfessional {}
public class DBA : SoftwareProfessional {}
public class Architect : SoftwareProfessional {}

public enum WorkType
{
    Code,
    CodeAndDesign,
    ModelAndTune,
    Everything
}

public static class SoftwareProfessionalFactory
{
    public static softwareProfessional GetSoftwareProfessional (WorkType workType)
    {
        switch (workType)
        {
            case WorkType.Code:
                return new Developer();
            case WorkType.CodeAndDesign:
                return new Designer();
            case WorkType.CodeAndManage:
                return new Manager();
            case WorkType.ModelAndTune:
                return new DBA();
            case WorkType.Everything:
                return new Architect();
            default:
                return new Arcitect();
        }
    }
}

Software SoftwareProfessional dev = SoftwareProfessionalFactory.GetSoftwareProfessional(WorkType.Code);