using ETSCore.Enums;

namespace ETSCore.Data;

public class DataHandler<T> {

    private DataHandlerState State;
    private List<T>          Data;

    public DataHandlerState GetState() {
        return State;
    }

    public List<T> GetData() {
        return Data;
    }

    public void SetState(DataHandlerState state) {
        State = state;
    }

    public bool HasFailed() {
        return State == DataHandlerState.Fail;
    }

}