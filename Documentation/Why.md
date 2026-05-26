# Why should I care?

### Your commit messages are documentation whether you like it or not
Every line of code you write gets annotated by a commit message — that's just how version control works. A bad message ("fix", "wip", "code review suggestions") is still an annotation, just a useless one. Commit messages are an opportunity to record the choices and tradeoffs you made without cluttering your code with comments. JJ lowers the friction of committing early and often, and lets you rewrite history in the way that will be most useful in the future.

It's also possible to give AI tools a copy of the commit history. A well-described sequence of changes gives an AI assistant meaningful context about your intent.

### AI tools deserve their own sandbox
AI coding tools can make broad, sweeping changes, not always in the direction you expected. With JJ, it's easy to spin up an anonymous branch and hand it to an AI tool to work on, completely separate from your own changes. If you like what it produced, you can pull in exactly the parts you want. If you don't, you abandon the branch and nothing is lost. JJ makes it practical to give AI tools the latitude they work best with, without putting your own work at risk.
