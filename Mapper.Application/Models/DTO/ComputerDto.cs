

using Mapper.Domain.Entities.Commons;
using Mapper.Domain.Entities.Enums;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;

namespace Mapper.Application.Models.DTO
{
    public record ComputerDto(
        int Id,
        DateTime Create,
        DateTime Update,
        bool Active,
        string? Cpu,
        string? MotherBoard,
        string? Gpu,
        string? Ram,
        string? Storage,
        string? Font,
        string? MacAddress,
        EStatusComputer Status,
        string? Info
        );

    public record NotebookDto(
        int Id,
        DateTime Create,
        DateTime Update,
        bool Active,
        string? Cpu,
        string? MotherBoard,
        string? Gpu,
        string? Ram,
        string? Storage,
        string? Font,
        string? MacAddress,
        string Name,
        string? Model,
        string Manufacturer,
        string? SerialNumber,
        EStatusComputer Status,
        string? Info) : ComputerDto(Id,Create,Update,Active,Cpu,MotherBoard,Gpu,Ram, Storage,Font,MacAddress,Status,Info);


    public record DesktopDto(
        int Id,
        DateTime Create,
        DateTime Update,
        bool Active,
        string? Cpu,
        string? MotherBoard,
        string? Gpu,
        string? Ram,
        string? Storage,
        string Cooler,
        string? Fan,
        string Cabinet,
        string? Font,
        string? MacAddress,
        EStatusComputer Status,
        string? Info
        ): ComputerDto(Id, Create, Update, Active, Cpu, MotherBoard, Gpu, Ram, Storage, Font, MacAddress,Status, Info);

}
