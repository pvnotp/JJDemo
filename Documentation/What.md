# What is JJ?

**Jujutsu** is an interface on top of Git.
    - Uses Git as its storage backend. 
    - Can be used in conjunction with Git on Git any Git remote.

### "Changes" not "Commits"
    - Every set of edits you make is called a "change" not a "commit" (although it does have a git hash and appears as a commit to git). 
    - JJ history is so easy to rewrite, there's no "commitment" to anything.  
    - This encourages blocking out sets of edits much more frequently.

### Changes have two IDs
    Every change in JJ has two identifiers:
    - A change id: an alphabetic id (e.g. "abcdefg", or just "abc" for short) that stays the same even after you amend or rebase the commit.
    - A commit id: the familiar Git hash, which changes any time the content changes.  This is what someone working with git will see.

### Your working changes are already commits
    - The moment you start editing files, those changes exist as a real commit. 
    - There is no staging area, no "git add", no stash.

### Don't be afraid: the operation log lets you undo anything
    - JJ records every operation performed on the repo (commits, rebases, pulls, pushes). 
    - The "jj undo" command steps back one operation at a time. 
    - Until code has shipped, there's no action in JJ you can't recover from.

### "Bookmarks" not "branches"
    - What Git calls a "branch" is called a "bookmark" in JJ. 
    - Bookmarks are optional. You can have a set of changes without assigning it to a branch.
    - Anonymous branches encourage you to use a branching structure with less friction.

### Conflicts schmonflicts
    - When a rebase or merge produces a conflict, JJ records the conflict inside the commit and keeps going. 
    - You can finish other work and resolve conflicts later — there's no interrupted state to manage.