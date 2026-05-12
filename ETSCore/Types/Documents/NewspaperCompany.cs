namespace ETSCore.Types;

public class NewspaperCompany {

    private string CompanyName;
    private int    CurrentVolume;
    private int    CurrentIssue;

    private NewspaperBias NewspaperBias;

    public NewspaperCompany(string companyName, int currentVolume, int currentIssue, NewspaperBias newspaperBias) {
        CompanyName   = companyName;
        CurrentVolume = currentVolume;
        CurrentIssue  = currentIssue;
        NewspaperBias = newspaperBias;
    }

    public void IncrementVolume() {
        CurrentVolume++;
    }

    public void DecrementVolume() {
        CurrentVolume--;
    }

    public void IncrementIssue() {
        CurrentIssue++;
    }

    public void DecrementIssue() {
        CurrentIssue--;
    }

}