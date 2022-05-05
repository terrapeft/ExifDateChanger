using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifDateChanger
{

    public class ExifToolVersion
    {
        public string id { get; set; }
        public string table { get; set; }
        public double val { get; set; }
    }

    public class Warning
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ExifTool
    {
        public ExifToolVersion ExifToolVersion { get; set; }
        public Warning Warning { get; set; }
    }

    public class FileName
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Directory
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FileSize
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FilePermissions
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FileType
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FileTypeExtension
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class MIMEType
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ExifByteOrder
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Orientation
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class XResolution
    {
        public int id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class YResolution
    {
        public int id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class ResolutionUnit
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Software
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class YCbCrPositioning
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ExposureTime
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FNumber
    {
        public int id { get; set; }
        public string table { get; set; }
        public double val { get; set; }
    }

    public class ISO
    {
        public int id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class ExifVersion
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ComponentsConfiguration
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ShutterSpeedValue
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ApertureValue
    {
        public int id { get; set; }
        public string table { get; set; }
        public double val { get; set; }
    }

    public class ExposureCompensation
    {
        public int id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class FlashpixVersion
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ColorSpace
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ExifImageWidth
    {
        public int id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class ExifImageHeight
    {
        public int id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class InteropIndex
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class InteropVersion
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class CustomRendered
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Compression
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ThumbnailOffset
    {
        public int id { get; set; }
        public int index { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class ThumbnailLength
    {
        public int id { get; set; }
        public int index { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class ImageWidth
    {
        public string id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class ImageHeight
    {
        public string id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class EncodingProcess
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class BitsPerSample
    {
        public string id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class ColorComponents
    {
        public string id { get; set; }
        public string table { get; set; }
        public int val { get; set; }
    }

    public class YCbCrSubSampling
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Aperture
    {
        public string id { get; set; }
        public string table { get; set; }
        public double val { get; set; }
    }

    public class ImageSize
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Megapixels
    {
        public string id { get; set; }
        public string table { get; set; }
        public double val { get; set; }
    }

    public class ShutterSpeed
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class LightValue
    {
        public string id { get; set; }
        public string table { get; set; }
        public double val { get; set; }
    }

    public class Image
    {
        public FileName FileName { get; set; }
        public Directory Directory { get; set; }
        public FileSize FileSize { get; set; }
        public FilePermissions FilePermissions { get; set; }
        public FileType FileType { get; set; }
        public FileTypeExtension FileTypeExtension { get; set; }
        public MIMEType MIMEType { get; set; }
        public ExifByteOrder ExifByteOrder { get; set; }
        public Orientation Orientation { get; set; }
        public XResolution XResolution { get; set; }
        public YResolution YResolution { get; set; }
        public ResolutionUnit ResolutionUnit { get; set; }
        public Software Software { get; set; }
        public YCbCrPositioning YCbCrPositioning { get; set; }
        public ExposureTime ExposureTime { get; set; }
        public FNumber FNumber { get; set; }
        public ISO ISO { get; set; }
        public ExifVersion ExifVersion { get; set; }
        public ComponentsConfiguration ComponentsConfiguration { get; set; }
        public ShutterSpeedValue ShutterSpeedValue { get; set; }
        public ApertureValue ApertureValue { get; set; }
        public ExposureCompensation ExposureCompensation { get; set; }
        public FlashpixVersion FlashpixVersion { get; set; }
        public ColorSpace ColorSpace { get; set; }
        public ExifImageWidth ExifImageWidth { get; set; }
        public ExifImageHeight ExifImageHeight { get; set; }
        public InteropIndex InteropIndex { get; set; }
        public InteropVersion InteropVersion { get; set; }
        public CustomRendered CustomRendered { get; set; }
        public Compression Compression { get; set; }
        public ThumbnailOffset ThumbnailOffset { get; set; }
        public ThumbnailLength ThumbnailLength { get; set; }
        public ImageWidth ImageWidth { get; set; }
        public ImageHeight ImageHeight { get; set; }
        public EncodingProcess EncodingProcess { get; set; }
        public BitsPerSample BitsPerSample { get; set; }
        public ColorComponents ColorComponents { get; set; }
        public YCbCrSubSampling YCbCrSubSampling { get; set; }
        public Aperture Aperture { get; set; }
        public ImageSize ImageSize { get; set; }
        public Megapixels Megapixels { get; set; }
        public ShutterSpeed ShutterSpeed { get; set; }
        public LightValue LightValue { get; set; }
    }

    public class FileModifyDate
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FileAccessDate
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FileCreateDate
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class ModifyDate
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class DateTimeOriginal
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class CreateDate
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class GPSTimeStamp
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class GPSDateStamp
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class GPSDateTime
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Time
    {
        public FileModifyDate FileModifyDate { get; set; }
        public FileAccessDate FileAccessDate { get; set; }
        public FileCreateDate FileCreateDate { get; set; }
        public ModifyDate ModifyDate { get; set; }
        public DateTimeOriginal DateTimeOriginal { get; set; }
        public CreateDate CreateDate { get; set; }
        public GPSTimeStamp GPSTimeStamp { get; set; }
        public GPSDateStamp GPSDateStamp { get; set; }
        public GPSDateTime GPSDateTime { get; set; }
    }

    public class Make
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Model
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class MeteringMode
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Flash
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FocalLength
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class WhiteBalance
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class FocalLength35efl
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Camera
    {
        public Make Make { get; set; }
        public Model Model { get; set; }
        public MeteringMode MeteringMode { get; set; }
        public Flash Flash { get; set; }
        public FocalLength FocalLength { get; set; }
        public WhiteBalance WhiteBalance { get; set; }
        public FocalLength35efl FocalLength35efl { get; set; }
    }

    public class GPSLatitudeRef
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class GPSLongitudeRef
    {
        public int id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class GPSLatitude
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class GPSLongitude
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class GPSPosition
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Location
    {
        public GPSLatitudeRef GPSLatitudeRef { get; set; }
        public GPSLongitudeRef GPSLongitudeRef { get; set; }
        public GPSLatitude GPSLatitude { get; set; }
        public GPSLongitude GPSLongitude { get; set; }
        public GPSPosition GPSPosition { get; set; }
    }

    public class ThumbnailImage
    {
        public string id { get; set; }
        public string table { get; set; }
        public string val { get; set; }
    }

    public class Preview
    {
        public ThumbnailImage ThumbnailImage { get; set; }
    }

    public class RootObject
    {
        public string SourceFile { get; set; }
        public ExifTool ExifTool { get; set; }
        public Image Image { get; set; }
        public Time Time { get; set; }
        public Camera Camera { get; set; }
        public Location Location { get; set; }
        public Preview Preview { get; set; }
    }

}
