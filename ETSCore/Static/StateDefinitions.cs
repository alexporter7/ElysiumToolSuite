using Stateless;

namespace ETSCore.Static;

public class StateDefinitions {

    public static StateMachine<StateEnums.ApplicationState, StateEnums.ApplicationTrigger>
        ApplicationStateMachine = new(StateEnums.ApplicationState.Initializing);

}