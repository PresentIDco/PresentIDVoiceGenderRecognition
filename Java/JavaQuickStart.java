HttpRequest request = HttpRequest.newBuilder()
		.uri(URI.create("https://voice-gender-recognition.p.rapidapi.com/api/gender"))
		.header("content-type", "multipart/form-data; boundary=---011000010111000001101001")
		.header("x-rapidapi-key", "1c8c1abfe5msh7360a3ec3b0be2fp1b001fjsn7c31862917bf")
		.header("x-rapidapi-host", "voice-gender-recognition.p.rapidapi.com")
		.method("POST", HttpRequest.BodyPublishers.ofString("-----011000010111000001101001\r
Content-Disposition: form-data; name=\"sound\"\r
\r
\r
-----011000010111000001101001--\r
\r
"))
		.build();
HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
