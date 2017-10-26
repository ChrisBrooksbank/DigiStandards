#Migrations

* Never modify your local connection strings to point to anything other than local. 
  The risk is a migration could run on a non local database.
  This could potentially be a migration which is not in master ( and may never be merged into master )
  Which would put database into a unknown state, which is serious problem.

* Never modify a migration which is already in master, in any way, or delete it.
  If a migration is only in a feature branch then its fine to amend, delete e.t.c
  But once its merged into master it forms part of the Truth.
