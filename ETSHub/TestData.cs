using System;
using System.Collections.Generic;
using System.Printing;
using System.Text.Json;
using ETSCore;
using ETSCore.Enums;
using ETSCore.Types;
using ETSCore.Types.Cities;
using ETSCore.Types.Cities.Residents;
using Microsoft.Extensions.Logging;

namespace ETSHub;

public class TestData {

    public static ILogger Log = ETSGlobalCore.LogFactory.CreateLogger<TestData>();

    public static City TestCity = new City(
        "Test City",
        DateTime.Now,
        100, //TODO: we don't need this if we have a list of residents probably
        100,
        new List<Resident>());

    public static District TestDistrict = new District("Test District", TestCity);

    public static Address TestAddress = new Address(
        new BlockPos(Dimension.Overworld, CardinalDirection.North, 10, 70, 10),
        TestCity,
        TestDistrict,
        1234,
        "Cherry Street");

    public static Resident TestResident1 = new Resident(
        "John",
        "Super",
        "Smith",
        27,
        TestAddress,
        Job.Librarian,
        new Wallet());

    public static void TestSerialization() {
        Log.LogInformation("Testing printing of info from initialized variable");
        Log.LogInformation($"{TestResident1.FirstName}\n{TestResident1.ResidentAddress.GetAddressString()}");
        Log.LogInformation("Testing serializtion of ETS Data in JSON");
        string test1 = JsonSerializer.Serialize(
            TestResident1);
        Log.LogInformation(test1);
    }

    public static void TestDeserialization() {
        Log.LogInformation("Testing deserializtion of ETS Data in JSON");
        
    }

}