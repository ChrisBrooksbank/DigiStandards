#Migration Merge Conflicts

* Make a note of what the last unconflicted migration does, e.g. in case it runs SQL or special code, or simply to check everything looks OK. 
* Then delete that migration. 
* add-migration with same name ( full name includes timestamp so will be unique )
* Test before pushing

You must test this locally before pushing, if you do it wrongly you may get two migrations sharing the same model hash, which will generate errors.

The best way is to drop the local database and check it is recreated.
( Or rename it to and rename back after successful test )

#Migration corruption : When two migrations share same model hash

If you see this error : "Unable to update database to match the current model because there are pending changes and automatic migration is disabled. Either write the pending model changes to a code-based migration or enable automatic migration. Set DbMigrationsConfiguration.AutomaticMigrationsEnabled to true to enable automatic migration."

It may be that the final migration has the wrong model hash. e.g. perhaps the last two migrations share the same model hash.

* You CANNOT manually roll back the migration, because the migration may have been propogated elsewhere to different databases.

In my example case
AddReferenceCodeToPetition was followed by AddedEmailTemplatesAndImportRunLog

In order to see what was going on I created a temporary migration in package manager :
Add-Migration Foo, examining foo migration showed it was trying to add referencecode column again.

I deleted Foo ( which was done as a test only )

I made a note of the existing AddReferenceCodeToPetition migration code, then deleted the migration.
Then re-added it with :
add-migration AddReferenceCodeToPetition, ( full name will also include timestamp, so its actually a new migration ), then edited it to put back hand written code that was in deleted migration.

I tested by dropping database and checked it was recreated it

I can then push and submit a merge request to fix migrations.

In this case devci database migrations table will contain a reference to a now deleted migration, but thats OK.