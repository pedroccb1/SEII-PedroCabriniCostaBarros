var preHistoricFish = "Cockerelitte";

var result = preHistoricFish switch
{
    "Hellobatis" => "Helobatis",
    "Cockerelitte" => "Cockerlitte",
    => "No match!"
};

Console.WriteLine("This is a " + result)
