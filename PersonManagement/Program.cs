using PersonManagement;
using System.Text.Json;

PersonRepository personRepository = new PersonRepository();

try
{
	//
	// TODO
	//

	using (var reader = new StreamReader("persons.json"))
	{
		var json = reader.ReadToEnd();
		var persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json, new JsonSerializerOptions()
		{
			PropertyNameCaseInsensitive = true
		});

		if (persons is null)
		{
			throw new Exception("Problem with deserialization");
		}

		personRepository.AddPersons(persons);
	} // .Dispose()
}
catch (FileNotFoundException fnfEx)
{
	Console.WriteLine(fnfEx.Message);
	return;
}

// TODO

//textWriter.WriteLine("=====================================================");
//textWriter.WriteLine("Person list");
//textWriter.WriteLine("=====================================================");
//
// TODO
//

//textWriter.WriteLine();
//textWriter.WriteLine("=====================================================");
//textWriter.WriteLine("Persons in Hagenberg");
//textWriter.WriteLine("=====================================================");
//
// TODO
//

//textWriter.WriteLine();
//textWriter.WriteLine("=====================================================");
//textWriter.WriteLine("Person names");
//textWriter.WriteLine("=====================================================");
//
// TODO
//

//textWriter.WriteLine();
//textWriter.WriteLine("=====================================================");
//textWriter.WriteLine($"Youngest person");
//textWriter.WriteLine("=====================================================");
//
// TODO
//

//textWriter.WriteLine();
//textWriter.WriteLine("=====================================================");
//textWriter.WriteLine("Persons sorted by age ascending");
//textWriter.WriteLine("=====================================================");
//
// TODO
//
