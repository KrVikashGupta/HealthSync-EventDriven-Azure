using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace HospitalFunctionApp;

public class Function1
{
	// ILogger — logs file details in Azure Portal → Invocations
	private readonly ILogger<Function1> _logger;

	// DI — ILogger injected automatically
	public Function1(ILogger<Function1> logger)
	{
		_logger = logger;
	}

	
	[Function(nameof(Function1))]
	public async Task Run(
		[BlobTrigger("medical-reports/{name}", Connection = "StorageConnection")] Stream stream,
		string name) 
	{
		try
		{
			_logger.LogInformation("Medical report received!");
			_logger.LogInformation("File name: {name}", name); 

			// read file content from Blob Storage
			using var blobStreamReader = new StreamReader(stream);
			var content = await blobStreamReader.ReadToEndAsync();

			_logger.LogInformation("File processed successfully. File: {name}", name);
		}
		catch (Exception ex)
		{
			// logs error and rethrows — visible in Invocations history
			_logger.LogError("Error while processing file {name}: {error}", name, ex.Message);
			throw;
		}
	}
}