import requests

url = "https://voice-gender-recognition.p.rapidapi.com/api/gender"

payload = "-----011000010111000001101001\r
Content-Disposition: form-data; name=\"sound\"\r
\r
\r
-----011000010111000001101001--\r
\r
"
headers = {
    'content-type': "multipart/form-data; boundary=---011000010111000001101001",
    'x-rapidapi-key': "API KEY",
    'x-rapidapi-host': "voice-gender-recognition.p.rapidapi.com"
    }

response = requests.request("POST", url, data=payload, headers=headers)

print(response.text)
