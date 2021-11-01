using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Authentication;
using LoginExample.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace LoginExample.Data.Impl {
public class InMemoryUserService : IUserService {
    private List<User> users;

    public User ValidateUser(string userName, string password) {
        try
        {
            Task<User> task = Task.Run<User>(async () => await getUserFromAPI(userName,password));
            return task.Result;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }

    public async Task<User> getUserFromAPI(string userName,string password)
    {
        HttpClient client = new HttpClient();

        string tmpString = "https://localhost:5005/UserLogin?userName=" + userName.ToString() + "&password=" + password.ToString();
        HttpResponseMessage responseMessage = await client.GetAsync(tmpString);
        Console.WriteLine(responseMessage.IsSuccessStatusCode);
        Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
        
        User user = JsonSerializer.Deserialize<User>  (responseMessage.Content.ReadAsStringAsync().Result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        return user;
    }
}
}