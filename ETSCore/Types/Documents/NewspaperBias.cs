namespace ETSCore.Types;

public class NewspaperBias {

    private int LowerBound;
    private int UpperBound;
    private int CurrentBias;

    public NewspaperBias(int lowerBound, int upperBound, int currentBias) {
        LowerBound  = lowerBound;
        UpperBound  = upperBound;
        CurrentBias = currentBias;
    }

    public int AdjustBias(int amount) {
        if (CurrentBias + amount > UpperBound)
            CurrentBias = UpperBound;
        else if (CurrentBias + amount < LowerBound)
            CurrentBias = LowerBound;
        else
            CurrentBias += amount;

        return CurrentBias;
    }

    public int IncrementBias() {
        return AdjustBias(1);
    }

    public int DecrementBias() {
        return AdjustBias(-1);
    }

    public void SetBias(int bias) {
        if (bias > UpperBound || bias < LowerBound)
            return;
        CurrentBias = bias;
    }

    public int GetBias() {
        return CurrentBias;
    }

}