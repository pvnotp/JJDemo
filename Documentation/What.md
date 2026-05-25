# What is JJ?

**Jujutsu** is a version control system that uses Git as its storage backend. Your commits look like regular Git commits, you can push and pull from any Git remote, and you can even run "jj" and "git" commands side-by-side in the same repo. Think of it as an interface on top of Git.

### "Changes" not "Commits"
Every set of edits you make is called a "change" not a "commit", although it does have a git hash and appears as a commit to git. The language says it all: git "commits" are a "commitment" to a set of edits that contain a working version of your code you may want to return to.  It's not meant to be rewritten (although of course git gives you many tools to do so if you choose).  However, JJ history is so easy to rewrite, there's no actual "commitment" to anything.  This encourages blocking out sets of edits much more frequently, even if the edits do not represent a working version of your code.

### Changes have two IDs
Every change in JJ has two identifiers:
- A change id: an alphabetic id (e.g. "abcdefg", or just "abc" for short) that stays the same even after you amend or rebase the commit.
- A commit id: the familiar Git hash, which changes any time the content changes.  This is what someone working with git will see.

### Your working changes are already commits
The moment you start editing files, those changes exist as a real commit. There is no staging area, no "git add", no stash. Every "jj" command automatically snapshots your working copy. This change has no messsage until you decide to give it one, even if you want to stack more changes on top of it.

### Don't be afraid: the operation log lets you undo anything
JJ records every operation performed on the repo (commits, rebases, pulls, pushes). The "jj undo" command steps back one operation at a time. Until code has shipped, there's no action in JJ you can't recover from.

### "Bookmarks" not "branches"
What Git calls a "branch" is called a "bookmark" in JJ. Unlike with git, bookmarks are optional. You can have a set of changes without assigning it to a branch, in fact with JJ your default state is headless.  JJ calls this an "anonymous branch", and because your changes are tracked by jj's change ids and the operation log, it is a safe state.  Anonymous branches encourage you to use a branching structure with less friction.

### Conflicts schmonflicts
When a rebase or merge produces a conflict, JJ records the conflict inside the commit and keeps going. You can finish other work and resolve conflicts later — there's no interrupted state to manage.