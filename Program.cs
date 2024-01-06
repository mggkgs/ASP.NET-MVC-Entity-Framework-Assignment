public ActionResult Create(InsureeViewModel viewModel)
{
    // Assuming you have a ViewModel named InsureeViewModel
    decimal baseQuote = 50;

    // Age logic
    if (viewModel.Age <= 18)
        baseQuote += 100;
    else if (viewModel.Age >= 19 && viewModel.Age <= 25)
        baseQuote += 50;
    else
        baseQuote += 25;

    // Car year logic
    if (viewModel.CarYear < 2000)
        baseQuote += 25;
    else if (viewModel.CarYear > 2015)
        baseQuote += 25;

    // Car Make logic
    if (viewModel.CarMake == "Porsche")
        baseQuote += 25;

    // Car Model logic
    if (viewModel.CarMake == "Porsche" && viewModel.CarModel == "911 Carrera")
        baseQuote += 25;

    // Speeding ticket logic
    baseQuote += viewModel.SpeedingTickets * 10;

    // DUI logic
    if (viewModel.HasDUI)
        baseQuote += baseQuote * 0.25;

    // Full coverage logic
    if (viewModel.FullCoverage)
        baseQuote += baseQuote * 0.5;

    // Now, you have the calculated quote in the 'baseQuote' variable

    // Rest of your code to save to the database, redirect, etc.

    return View();
}