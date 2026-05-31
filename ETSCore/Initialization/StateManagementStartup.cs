using ETSCore.Static;
using Microsoft.Extensions.Logging;

namespace ETSCore.Initialization;

public class StateManagementStartup {

    private static ILogger Logger;
    
    public static void Start(ETSAppCore appCore) {
        Logger = appCore.Factory.CreateLogger<StateManagementStartup>();
        Logger.LogInformation("Starting State Management Setup");
        DefineStates();
    }

    public static void DefineStates() {
        
        Logger.LogInformation("Defining ApplicationStateMachine");
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.Initializing)
                        .Permit(StateEnums.ApplicationTrigger.StepComplete,
                            StateEnums.ApplicationState.CheckApplicationData)
                        .Permit(StateEnums.ApplicationTrigger.StepFailed, StateEnums.ApplicationState.Error);
        
        
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.CheckApplicationData);
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.FirstTimeStartup);
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.ApplicationStartup);
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.LoadConfigData);
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.Active);
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.Error);
        StateDefinitions.ApplicationStateMachine.Configure(StateEnums.ApplicationState.Idle);
    }
    
    

}