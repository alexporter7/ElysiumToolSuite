namespace ETSCore.Static;

public class StateEnums {

    public enum ApplicationState {

        Initializing,
        CheckApplicationData,
        FirstTimeStartup,
        ApplicationStartup,
        LoadConfigData,
        Active,
        Error,
        Idle

    }

    public enum ApplicationTrigger {

        StepComplete,
        StepFailed

    }

}