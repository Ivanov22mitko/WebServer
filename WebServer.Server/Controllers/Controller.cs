using System.Runtime.CompilerServices;
using WebServer.Server.HTPP;
using WebServer.Server.Responses;

namespace WebServer.Server.Controllers
{
    public abstract class Controller
    {
        protected Request Request { get; private init; }

        protected Controller(Request request)
        {
            this.Request = request;
        }

        protected Response Text(string text) => new TextResponse(text);

        protected Response Html(string html, CookieCollection cookies = null)
        {
            var response = new HtmlResponse(html);

            if (cookies != null)
            {
                foreach (var cookie in cookies)
                {
                    response.Cookies.Add(cookie.Name, cookie.Value);
                }
            }

            return response;
        }

        protected Response View([CallerMemberName] string viewName = "")
            => new ViewResponse(viewName, this.GetControllerName());

        protected Response View(object model, [CallerMemberName] string viewName = "")
            => new ViewResponse(viewName, this.GetControllerName(), model);

        private string GetControllerName()
            => this.GetType().Name
            .Replace(nameof(Controller), string.Empty);

        protected Response BadRequest() => new BadRequestResponse();
        
        protected Response Unauthorised(string text) => new UnauthorizedResponse();
        
        protected Response NotFound() => new NotFoundResponse();
        
        protected Response Redirect(string location) => new RedirectResponse(location);
        
        protected Response File(string fileName) => new TextFileResponse(fileName);
    }
}
