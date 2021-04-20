# How to run this app

This is a .NetCore project.

To run this project, follow the steps below.

*Clone the repostory from Github or download and extract the zip file on to your computer

```bash
git clone https://github.com/LawrenceOnen/promo_code.git
```

Change into the project directory from your current directory

```bash
cd promo_code
```

*Build the project succesfully by running the following command on your terminal

```bash
dotnet build Promocodes
```

## First ensure all tests are passing

*Change to the test directory from the project directory

```bash
cd ../test
```

*Run all the test. If all tests

```bash
dotnet test
```

*After the successful test run, run the project using the command below

```bash
dotnet run --project Promocodes
```

## Set up MSSQL on a mac using docker

[](https://database.guide/how-to-install-sql-server-on-a-mac/)
[](https://code.visualstudio.com/docs/containers/quickstart-aspnet-core)

## Fire up docker compose to start the db

```bash
docker-compose up
```
